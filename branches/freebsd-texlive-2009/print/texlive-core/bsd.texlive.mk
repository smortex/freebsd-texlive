
TEXLIVE_RELEASE=	2009
PORTVERSION?=		${TEXLIVE_RELEASE}
MASTER_SITES?=		${MASTER_SITE_TEX_CTAN}
MASTER_SITE_SUBDIR?=	systems/texlive/tlnet/archive
DIST_SUBDIR=		TeXLive/${TEXLIVE_RELEASE}
PKGNAMEPREFIX=		texlive-
#DISTNAME=		${PORTNAME}

RUN_DEPENDS+=		mktexlsr:${PORTSDIR}/print/texlive-core

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

USE_XZ=		yes
NO_BUILD=	yes

${WRKDIR}/.install_files: build
	@(  cd ${WRKDIR} && cat tlpkg/tlpobj/${PORTNAME}.tlpobj | awk '\
		$$0 ~ /^ / { \
		    source=$$1; \
		    target="share/$$1"; \
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
	@(  cd ${WRKDIR} && cat tlpkg/tlpobj/${PORTNAME}.doc.tlpobj | awk '\
		$$0 ~ /^ / { \
		    source=$$1; \
		    target=$$1; \
		    if (index($$1, "RELOC/")) { \
			sub("RELOC/", "", source); \
			sub("RELOC/", "share/texmf-dist/", target); \
		    } \
		    if (system("[ -e ${PREFIX}/" target " ]") != 0) { \
			print source "	" target "	%%PORTDOCS%%"; \
		    } \
		}' >> ${WRKDIR}/.install_files; \
	)
.endif
.if !defined(NOPORTSRC)
	@(  cd ${WRKDIR} && cat tlpkg/tlpobj/${PORTNAME}.source.tlpobj | awk '\
		$$0 ~ /^ / { \
		    source=$$1; \
		    target=$$1; \
		    if (index($$1, "RELOC/")) { \
			sub("RELOC/", "", source); \
			sub("RELOC/", "share/texmf-dist/", target); \
		    } \
		    if (system("[ -e ${PREFIX}/" target " ]") != 0) { \
			print source "	" target "	%%PORTSRC%%"; \
		    } \
		}' >> ${WRKDIR}/.install_files; \
	)
.endif

pkg-plist: ${WRKDIR}/.install_files
	@sort -k 2 < ${WRKDIR}/.install_files | awk ' { print $$3 $$2 } ' > ${PLIST}
	@for dir in `cut -f 2 < ${WRKDIR}/.install_files | xargs dirname | sort -r | uniq`; do \
	    if [ ! -d "${PREFIX}/$$dir" ]; then \
		echo @dirrmtry $$dir >> ${PLIST} ;\
	    fi; \
	done

do-install: ${WRKDIR}/.install_files
	@for dir in `cut -f 2 < ${WRKDIR}/.install_files | xargs dirname | sort -r | uniq`; do \
	    if [ ! -d "${PREFIX}/$$dir" ]; then \
		${MKDIR} "${PREFIX}/$$dir" ;\
	    fi; \
	done
	@(  cd ${WRKDIR} && while read source target junk; do \
		${INSTALL_DATA} $$source ${PREFIX}/$$target; \
	    done < ${WRKDIR}/.install_files \
	)

# updmap seems to be part of the deprecated teTeX...  Some work may be needed here.
post-install:
	@(  if grep -q '\.map$$' ${PLIST} && [ -f ${LOCALBASE}/share/texmf/web2c/updmap.cfg ] ; then \
		echo "Updating font map files..."; \
		${PREFIX}/bin/updmap-sys --syncwithtrees; \
	    else \
		echo "Updating ls-R databases..."; \
		${PREFIX}/bin/mktexlsr; \
	    fi \
	)

