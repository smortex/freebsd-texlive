# $FreeBSD$

PORTNAME=	xltxtra
PORTVERSION=	20160414
PORTEPOCH=	1
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	"Extras" for LaTeX users of XeTeX

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/tex/latex/metalogo/metalogo.sty:${PORTSDIR}/print/texlive-metalogo

OPTIONS_DEFINE=	DOCS SRCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
