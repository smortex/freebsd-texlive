# New ports collection makefile for:	texlive-context-gantt
# Date created:		09/06/2011 04:40:54
# Whom:		romain@FreeBSD.org
#
# $FreeBSD$
#

PORTNAME=	context-gantt
PORTVERSION=	20120314
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	GANTT module for ConTeXt.

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/bibtex/bst/context/cont-ab.bst:${PORTSDIR}/print/texlive-context \
		${LOCALBASE}/share/texmf-dist/metapost/hatching/hatching.mp:${PORTSDIR}/print/texlive-hatching

NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
