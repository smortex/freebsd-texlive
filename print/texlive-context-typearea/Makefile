# New ports collection makefile for:	texlive-context-typearea
# Date created:		13/03/2010 04:21:47
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	context-typearea
PORTVERSION=	20110721
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Something like Koma-Script typearea.

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/bibtex/bst/context/cont-ab.bst:${PORTSDIR}/print/texlive-context

NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
