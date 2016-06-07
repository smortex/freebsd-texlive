# $FreeBSD$

PORTNAME=	japanese-otf-uptex
PORTVERSION=	20160414
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Support for Japanese OTF files in upLaTeX

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/fonts/map/dvipdfmx/japanese-otf/otf-cktx.map:${PORTSDIR}/print/texlive-japanese-otf

OPTIONS_DEFINE=	DOCS SRCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
