# $FreeBSD$

PORTNAME=	graphics
PORTVERSION=	20160714
PORTEPOCH=	1
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	The LaTeX standard graphics bundle

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/tex/latex/graphics-cfg/color.cfg:${PORTSDIR}/print/texlive-graphics-cfg

OPTIONS_DEFINE=	DOCS SRCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
