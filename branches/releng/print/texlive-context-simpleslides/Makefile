# New ports collection makefile for:	texlive-context-simpleslides
# Date created:		13/03/2010 04:21:45
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	context-simpleslides
PORTVERSION=	20120215
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	A module for preparing presentations.

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/bibtex/bst/context/cont-ab.bst:${PORTSDIR}/print/texlive-context

NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
