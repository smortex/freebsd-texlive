
TEXLIVE_RELEASE=	2008
PORTVERSION?=		${TEXLIVE_RELEASE}
MASTER_SITES?=		${MASTER_SITE_TEX_CTAN}
MASTER_SITE_SUBDIR?=	systems/texlive/tlnet/${TEXLIVE_RELEASE}/archive
DIST_SUBDIR=		TeXLive/${TEXLIVE_RELEASE}
PKGNAMEPREFIX=		texlive-
#DISTNAME=		${PORTNAME}

RUN_DEPENDS+=		mktexlsr:${PORTSDIR}/print/texlive

DISTFILES=		${PORTNAME}${EXTRACT_SUFX}
.if !defined(NOPORTDOCS)
DISTFILES+=		${PORTNAME}.doc${EXTRACT_SUFX}
.endif
.if !defined(NOPORTSRC)
DISTFILES+=		${PORTNAME}.source${EXTRACT_SUFX}
.endif

USE_LZMA=	yes
NO_BUILD=	yes

PLIST=		${WRKDIR}/pkg-plist

pre-install:
	@${RM} -f ${PLIST}
	@echo "Generating pkg-plist..."
	@cd ${WRKDIR} && ( \
		if [ -d texmf ]; then ${FIND} texmf -type f | sed -e 's|^|share/|'; fi ;\
		if [ -d texmf-dist ]; then ${FIND} texmf-dist -type f | sed -e 's|^|share/|'; fi ;\
		if [ -d texmf-dist ];then ${FIND} texmf-dist -type d | sort -r | sed -e 's|^|@dirrmtry share/|' ; fi ;\
		if [ -d texmf ]; then ${FIND} texmf -type d | sort -r | sed -e 's|^|@dirrmtry share/|' ; fi ;\
	) > ${PLIST}
	@echo "Fixing permissions..."
	${CHMOD} -R =rw,+X ${WRKDIR}
	${CHOWN} -R root:wheel ${WRKDIR}

do-install:
	if [ -d ${WRKDIR}/texmf ]; then cp -a ${WRKDIR}/texmf ${PREFIX}/share; fi
	if [ -d ${WRKDIR}/texmf-dist ]; then cp -a ${WRKDIR}/texmf-dist ${PREFIX}/share; fi

post-install:
	@echo "Updating ls-R databases..."
	@mktexlsr

