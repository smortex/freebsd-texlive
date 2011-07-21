# New ports collection makefile for:	texlive-context-algorithmic
# Date created:		13/03/2010 04:21:29
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	context-algorithmic
PORTVERSION=	20110721
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Algorithm handling.

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/bibtex/bst/context/cont-ab.bst:${PORTSDIR}/print/texlive-context

NOPORTDOCS=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
