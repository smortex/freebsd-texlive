# New ports collection makefile for:	texlive-context-letter
# Date created:		13/03/2010 04:21:39
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	context-letter
PORTVERSION=	20120828
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Context package for writing letters.

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/bibtex/bst/context/cont-ab.bst:${PORTSDIR}/print/texlive-context

NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
