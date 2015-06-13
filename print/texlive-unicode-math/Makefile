# $FreeBSD$

PORTNAME=	unicode-math
PORTVERSION=	20150413
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Unicode mathematics support for XeTeX and LuaTeX.

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/tex/latex/fontspec/fontspec.sty:${PORTSDIR}/print/texlive-fontspec

OPTIONS_DEFINE=	DOCS SRCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
