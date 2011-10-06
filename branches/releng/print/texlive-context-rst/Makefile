# New ports collection makefile for:	texlive-context-rst
# Date created:		05/11/2011 04:38:47
# Whom:		romain@FreeBSD.org
#
# $FreeBSD$
#

PORTNAME=	context-rst
PORTVERSION=	20111006
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Process reStructuredText with ConTeXt.

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/bibtex/bst/context/cont-ab.bst:${PORTSDIR}/print/texlive-context

NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
