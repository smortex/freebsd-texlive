
PORTVERSION?=		20110705
MASTER_SITES?=		http://texlive-distfiles.blogreen.org/
DIST_SUBDIR=		TeXLive
PKGNAMEPREFIX=		texlive-

RUN_DEPENDS+=		mktexlsr:${PORTSDIR}/print/texlive-core

DISTFILES=		${PORTNAME}-${PORTVERSION}${EXTRACT_SUFX}
.if ${PORT_OPTIONS:MDOCS}
DISTFILES+=		${PORTNAME}.doc-${PORTVERSION}${EXTRACT_SUFX}
.endif
.if ${PORT_OPTIONS:MSRCS}
DISTFILES+=		${PORTNAME}.source-${PORTVERSION}${EXTRACT_SUFX}
PLIST_SUB+=		PORTSRC=""
.else
PLIST_SUB+=		PORTSRC="@comment "
.endif

#FETCH_ARGS=	-ApR	# Do NOT restart a previously interrupted transfer
NO_BUILD=	yes
NO_WRKSUBDIR=	yes
USES=		tar:xz

UNIQ?=		/usr/bin/uniq # This should be included in ports/Mk/bsd.commands.mk

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
		    }' | (${GREP} -vF ../../print/texlive-core/pkg-plist || :) > ${WRKDIR}/.install_files; \
	)
.if ${PORT_OPTIONS:MDOCS}
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
		    }' | (${GREP} -vF ../../print/texlive-core/pkg-plist || :) >> ${WRKDIR}/.install_files; \
	)
.endif
.if ${PORT_OPTIONS:MSRCS}
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
		    }' | (${GREP} -vF ../../print/texlive-core/pkg-plist || :) >> ${WRKDIR}/.install_files; \
	)
.endif

pkg-plist: ${WRKDIR}/.install_files
	@${SORT} -t',' -k 2 < ${WRKDIR}/.install_files | ${AWK} -F',' ' { print $$3 $$2 } ' > ${PLIST}
	@${ECHO} '@unexec if [ -z $${WITHOUT_TEXLIVE_MKTEXLSR} ]; then echo "Updating ls-R databases..."; %D/bin/mktexlsr; else printf "WITHOUT_TEXLIVE_MKTEXLSR is set.  Not running mktexlsr(1).\\nYou MUST run mktexlsr(1) to update TeXLive installed files database.\\n"; fi' >> ${PLIST}
	@${ECHO} '@exec if [ -z $${WITHOUT_TEXLIVE_MKTEXLSR} ]; then echo "Updating ls-R databases..."; %D/bin/mktexlsr; else printf "WITHOUT_TEXLIVE_MKTEXLSR is set.  Not running mktexlsr(1).\\nYou MUST run mktexlsr(1) to update TeXLive installed files database.\\n"; fi' >> ${PLIST}

do-install:
	@${GREP} -v '^@' ${TMPPLIST} | lam -s '${STAGEDIR}${PREFIX}/' - | xargs -L1 dirname | xargs ${MKDIR}
	@${AWK} '$$0 !~ /^@/ { src = $$0;  sub("share/texmf-dist", "${WRKDIR}", src); system("${INSTALL_DATA} "src" ${STAGEDIR}${PREFIX}/"$$0); }' < ${TMPPLIST}
