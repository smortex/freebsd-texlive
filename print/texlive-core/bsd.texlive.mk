
PORTVERSION?=		20110705
MASTER_SITES?=		http://texlive-distfiles.blogreen.org/
DIST_SUBDIR=		TeXLive
PKGNAMEPREFIX=		texlive-

RUN_DEPENDS+=		mktexlsr:${PORTSDIR}/print/texlive-core

DISTFILES=		${PORTNAME}-${PORTVERSION}${EXTRACT_SUFX}
.if !defined(NOPORTDOCS)
DISTFILES+=		${PORTNAME}.doc-${PORTVERSION}${EXTRACT_SUFX}
.endif
.if !defined(NOPORTSRC)
DISTFILES+=		${PORTNAME}.source-${PORTVERSION}${EXTRACT_SUFX}
PLIST_SUB+=		PORTSRC=""
.else
PLIST_SUB+=		PORTSRC="@comment"
.endif

FETCH_ARGS=	-ApR	# Do NOT restart a previously interrupted transfer
USE_XZ=		yes
NO_BUILD=	yes
NO_WRKSUBDIR=	yes

MKTEXLSR=	${PREFIX}/bin/mktexlsr

${WRKDIR}/.install_files: build
	@(  cd ${WRKDIR} && ${CAT} tlpkg/tlpobj/${PORTNAME}.tlpobj | ${GREP} ^\  | ${AWK} '\
		{ \
		    source=substr($$0, 2, length($$0)); \
		    target="share/" source; \
		    if (index(source, "RELOC/")) { \
			sub("RELOC/", "", source); \
			sub("RELOC/", "texmf-dist/", target); \
		    } \
		    if (system("[ -e \"${PREFIX}/" target "\" ]") != 0) { \
			print source "," target ","; \
		    } \
		}' | ${GREP} -vF ../../print/texlive-core/pkg-plist > ${WRKDIR}/.install_files; \
	)
.if !defined(NOPORTDOCS)
	@(  cd ${WRKDIR} && ${CAT} tlpkg/tlpobj/${PORTNAME}.doc.tlpobj | ${GREP} ^\  | ${AWK} '\
		{ \
		    source=substr($$0, 2, length($$0)); \
		    target="share/" source; \
		    if (index(source, "RELOC/")) { \
			sub("RELOC/", "", source); \
			sub("RELOC/", "texmf-dist/", target); \
		    } \
		    if (system("[ -e \"${PREFIX}/" target "\" ]") != 0) { \
			print source "," target ",%%PORTDOCS%%"; \
		    } \
		}' | ${GREP} -vF ../../print/texlive-core/pkg-plist >> ${WRKDIR}/.install_files; \
	)
.endif
.if !defined(NOPORTSRC)
	@(  cd ${WRKDIR} && ${CAT} tlpkg/tlpobj/${PORTNAME}.source.tlpobj | ${GREP} ^\  | ${AWK} '\
		{ \
		    source=substr($$0, 2, length($$0)); \
		    target="share/" source; \
		    if (index(source, "RELOC/")) { \
			sub("RELOC/", "", source); \
			sub("RELOC/", "texmf-dist/", target); \
		    } \
		    if (system("[ -e \"${PREFIX}/" target "\" ]") != 0) { \
			print source "," target ",%%PORTSRC%%"; \
		    } \
		}' | ${GREP} -vF ../../print/texlive-core/pkg-plist >> ${WRKDIR}/.install_files; \
	)
.endif

pkg-plist: ${WRKDIR}/.install_files
	@${SORT} -t',' -k 2 < ${WRKDIR}/.install_files | ${AWK} -F',' ' { print $$3 $$2 } ' > ${PLIST}
	@for dir in `${CUT} -d',' -f 2 < ${WRKDIR}/.install_files | ${XARGS} dirname | ${SORT} -r | uniq`; do \
	    if [ ! -d "${PREFIX}/$$dir" ]; then \
		${ECHO} @dirrmtry $$dir >> ${PLIST} ;\
	    fi; \
	done
	@${ECHO} "@exec %D/bin/mktexlsr" >> ${PLIST}
	@${ECHO} "@unexec %D/bin/mktexlsr" >> ${PLIST}

do-install: ${WRKDIR}/.install_files
	@for dir in `${CUT} -d',' -f 2 < ${WRKDIR}/.install_files | ${XARGS} dirname | ${SORT} -r | uniq`; do \
	    if [ ! -d "${PREFIX}/$$dir" ]; then \
		${MKDIR} "${PREFIX}/$$dir" ;\
	    fi; \
	done
	@( cd ${WRKDIR} && IFS="," && while read source target junk; do \
		${INSTALL_DATA} $$source ${PREFIX}/$$target; \
	    done < ${WRKDIR}/.install_files \
	)

post-install:
.if defined(WITHOUT_TEXLIVE_MKTEXLSR)
	@${ECHO} "WITHOUT_TEXLIVE_MKTEXLSR is set.  Not running ${MKTEXLSR}."
	@${ECHO} "You MUST run 'mktexlsr' to update TeXLive installed files database."
.else
	@${ECHO} "Updating ls-R databases..."
	@${MKTEXLSR}
.endif

