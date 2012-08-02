# New ports collection makefile for:	texlive-collection-documentation-serbian
# Date created:		09/21/2010 11:36:19
# Whom:		romain@FreeBSD.org
#
# $FreeBSD$
#

PORTNAME=	collection-documentation-serbian
PORTVERSION=	20100624
CATEGORIES=	print
DISTFILES=	# None

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Serbian documentation

RUN_DEPENDS=	${LOCALBASE}/share/texmf/scripts/texlive/var/texcatalogue.keywords:${PORTSDIR}/print/texlive-texlive-docindex

NOPORTDOCS=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
