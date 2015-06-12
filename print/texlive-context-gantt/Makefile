# $FreeBSD$

PORTNAME=	context-gantt
PORTVERSION=	20150412
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	GANTT module for ConTeXt.

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/bibtex/bst/context/cont-ab.bst:${PORTSDIR}/print/texlive-context \
		${LOCALBASE}/share/texmf-dist/metapost/hatching/hatching.mp:${PORTSDIR}/print/texlive-hatching

OPTIONS_DEFINE=	DOCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
