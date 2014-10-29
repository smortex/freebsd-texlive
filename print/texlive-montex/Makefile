# $FreeBSD$

PORTNAME=	montex
PORTVERSION=	20140418
PORTEPOCH=	1
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Mongolian LaTeX.

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/fonts/enc/dvips/cbfonts/CB.enc:${PORTSDIR}/print/texlive-cbfonts

OPTIONS_DEFINE=	DOCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
