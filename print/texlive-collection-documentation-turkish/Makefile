# New ports collection makefile for:	texlive-collection-documentation-turkish
# Date created:		13/03/2010 04:25:07
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	collection-documentation-turkish
PORTVERSION=	20100610
PORTEPOCH=	1
CATEGORIES=	print
DISTFILES=	# None

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Turkish documentation

RUN_DEPENDS=	${LOCALBASE}/share/texmf/scripts/texlive/var/texcatalogue.keywords:${PORTSDIR}/print/texlive-texlive-docindex

NOPORTDOCS=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
