# $FreeBSD$

PORTNAME=	texpower
PORTVERSION=	20160414
PORTEPOCH=	1
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Create dynamic online presentations with LaTeX

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/tex/latex/tpslifonts/tpslifonts.sty:${PORTSDIR}/print/texlive-tpslifonts

OPTIONS_DEFINE=	DOCS SRCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
