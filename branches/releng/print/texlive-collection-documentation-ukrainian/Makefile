# New ports collection makefile for:	texlive-collection-documentation-ukrainian
# Date created:		13/03/2010 04:25:08
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	collection-documentation-ukrainian
PORTVERSION=	20100610
PORTEPOCH=	1
CATEGORIES=	print
DISTFILES=	# None

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Ukrainian documentation

RUN_DEPENDS=	${LOCALBASE}/share/texmf/scripts/texlive/var/texcatalogue.keywords:${PORTSDIR}/print/texlive-texlive-docindex

NOPORTDOCS=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
