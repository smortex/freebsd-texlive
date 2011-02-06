# New ports collection makefile for:	kotex-macros
# Date created:		2011-02-06
# Whom:			Romain Tartiere <romain@FreeBSD.org>
#
# $FreeBSD$
#

PORTNAME=	kotex-macros
PORTVERSION=	20100511
CATEGORIES=	print
MASTER_SITES=	http://ftp.ktug.or.kr/KTUG/ko.TeX/

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Korean support for LaTeX (macros)

NO_BUILD=	yes
WRKSRC=		${WRKDIR}
MKTEXLSR=	${LOCALBASE}/bin/mktexlsr

INSTALL_DEPENDS=${MKTEXLSR}:${PORTSDIR}/print/texlive-core

do-install:
	@(cd ${WRKSRC} && ${COPYTREE_SHARE} "bibtex fonts makeindex tex" ${PREFIX}/share/texmf-dist/ )
.if !defined(NOPORTDOCS)
	@(cd ${WRKSRC} && ${COPYTREE_SHARE} doc ${PREFIX}/share/texmf-dist/ )
.endif

post-install:
.if defined(WITHOUT_TEXLIVE_MKTEXLSR)
	@echo "WITHOUT_TEXLIVE_MKTEXLSR is set.  Not running ${MKTEXLSR}."
	@echo "You MUST run 'mktexlsr' to update TeXLive installed files database."
.else
	@echo "Updating ls-R databases..."
	@${MKTEXLSR}
.endif

.include <bsd.port.mk>
