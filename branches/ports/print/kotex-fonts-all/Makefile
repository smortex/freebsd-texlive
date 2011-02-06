# New ports collection makefile for:	kotex-fonts-all
# Date created:		2011-02-06
# Whom:			Romain Tartiere <romain@FreeBSD.org>
#
# $FreeBSD$
#

PORTNAME=	kotex-fonts-all
PORTVERSION=	20100509
CATEGORIES=	print
MASTER_SITES=	http://ftp.ktug.or.kr/KTUG/ko.TeX/

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Korean support for LaTeX (fonts)

NO_BUILD=	yes
WRKSRC=		${WRKDIR}
MKTEXLSR=	${LOCALBASE}/bin/mktexlsr

do-install:
	@(cd ${WRKSRC} && ${COPYTREE_SHARE} fonts ${PREFIX}/share/texmf-dist/ )

post-install:
.if defined(WITHOUT_TEXLIVE_MKTEXLSR)
	@echo "WITHOUT_TEXLIVE_MKTEXLSR is set.  Not running ${MKTEXLSR}."
	@echo "You MUST run 'mktexlsr' to update TeXLive installed files database."
.else
	@echo "Updating ls-R databases..."
	@${MKTEXLSR}
.endif

.include <bsd.port.mk>
