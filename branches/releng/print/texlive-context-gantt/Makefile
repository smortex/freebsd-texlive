# $FreeBSD$

PORTNAME=	context-gantt
PORTVERSION=	20120821
PORTREVISION=	1
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	GANTT module for ConTeXt.

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/bibtex/bst/context/cont-ab.bst:${PORTSDIR}/print/texlive-context \
		${LOCALBASE}/share/texmf-dist/metapost/hatching/hatching.mp:${PORTSDIR}/print/texlive-hatching

NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
