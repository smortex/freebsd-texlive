# $FreeBSD$

PORTNAME=	forest
PORTVERSION=	20161220
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Drawing (linguistic) trees

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/tex/latex/elocalloc/elocalloc.sty:${PORTSDIR}/print/texlive-elocalloc

OPTIONS_DEFINE=	DOCS SRCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
