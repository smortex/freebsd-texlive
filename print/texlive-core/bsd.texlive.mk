
PORTVERSION?=		20110705
MASTER_SITES?=		${MASTER_SITE_TEX_CTAN}
MASTER_SITE_SUBDIR?=	systems/texlive/tlnet/archive
DIST_SUBDIR=		TeXLive
PKGNAMEPREFIX=		texlive-
#DISTNAME=		${PORTNAME}

RUN_DEPENDS+=		mktexlsr:${PORTSDIR}/print/texlive-core

MASTER_SITE_TEX_CTAN+=	http://distrib-coffee.ipsl.jussieu.fr/pub/mirrors/ctan/%SUBDIR%/

DISTFILES=		${PORTNAME}${EXTRACT_SUFX}
.if !defined(NOPORTDOCS)
DISTFILES+=		${PORTNAME}.doc${EXTRACT_SUFX}
.endif
.if !defined(NOPORTSRC)
DISTFILES+=		${PORTNAME}.source${EXTRACT_SUFX}
PLIST_SUB+=		PORTSRC=""
.else
PLIST_SUB+=		PORTSRC="@comment"
.endif

FETCH_ARGS=	-ApR	# Do NOT restart a previously interrupted transfer
USE_XZ=		yes
NO_BUILD=	yes

MKTEXLSR=	${PREFIX}/bin/mktexlsr

${WRKDIR}/.install_files: build
	@(  cd ${WRKDIR} && ${CAT} tlpkg/tlpobj/${PORTNAME}.tlpobj | ${AWK} '\
		$$0 ~ /^ / { \
		    source=$$1; \
		    target="share/" $$1; \
		    if (index($$1, "RELOC/")) { \
			sub("RELOC/", "", source); \
			sub("RELOC/", "texmf-dist/", target); \
		    } \
		    if (system("[ -e ${PREFIX}/" target " ]") != 0) { \
			print source "	" target; \
		    } \
		}' > ${WRKDIR}/.install_files; \
	)
.if !defined(NOPORTDOCS)
	@(  cd ${WRKDIR} && ${CAT} tlpkg/tlpobj/${PORTNAME}.doc.tlpobj | ${AWK} '\
		$$0 ~ /^ / { \
		    source=$$1; \
		    target="share/" $$1; \
		    if (index($$1, "RELOC/")) { \
			sub("RELOC/", "", source); \
			sub("RELOC/", "texmf-dist/", target); \
		    } \
		    if (system("[ -e ${PREFIX}/" target " ]") != 0) { \
			print source "	" target "	%%PORTDOCS%%"; \
		    } \
		}' >> ${WRKDIR}/.install_files; \
	)
.endif
.if !defined(NOPORTSRC)
	@(  cd ${WRKDIR} && ${CAT} tlpkg/tlpobj/${PORTNAME}.source.tlpobj | ${AWK} '\
		$$0 ~ /^ / { \
		    source=$$1; \
		    target="share/" $$1; \
		    if (index($$1, "RELOC/")) { \
			sub("RELOC/", "", source); \
			sub("RELOC/", "texmf-dist/", target); \
		    } \
		    if (system("[ -e ${PREFIX}/" target " ]") != 0) { \
			print source "	" target "	%%PORTSRC%%"; \
		    } \
		}' >> ${WRKDIR}/.install_files; \
	)
.endif

pkg-plist: ${WRKDIR}/.install_files
	@${SORT} -k 2 < ${WRKDIR}/.install_files | ${AWK} ' { print $$3 $$2 } ' > ${PLIST}
	@for dir in `${CUT} -f 2 < ${WRKDIR}/.install_files | ${XARGS} dirname | ${SORT} -r | uniq`; do \
	    if [ ! -d "${PREFIX}/$$dir" ]; then \
		${ECHO} @dirrmtry $$dir >> ${PLIST} ;\
	    fi; \
	done
	@echo "@exec %D/bin/mktexlsr" >> ${PLIST}
	@echo "@unexec %D/bin/mktexlsr" >> ${PLIST}

do-install: ${WRKDIR}/.install_files
	@for dir in `${CUT} -f 2 < ${WRKDIR}/.install_files | ${XARGS} dirname | ${SORT} -r | uniq`; do \
	    if [ ! -d "${PREFIX}/$$dir" ]; then \
		${MKDIR} "${PREFIX}/$$dir" ;\
	    fi; \
	done
	@(  cd ${WRKDIR} && while read source target junk; do \
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

