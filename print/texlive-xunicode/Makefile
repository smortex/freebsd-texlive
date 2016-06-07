# $FreeBSD$

PORTNAME=	xunicode
PORTVERSION=	20160414
PORTEPOCH=	1
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Generate Unicode characters from accented glyphs

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/tex/latex/tipa/tipa.sty:${PORTSDIR}/print/texlive-tipa

OPTIONS_DEFINE=	DOCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
