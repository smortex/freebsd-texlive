# $FreeBSD$

PORTNAME=	ctex
PORTVERSION=	20150620
PORTEPOCH=	1
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	LaTeX classes and packages for Chinese typesetting.

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/fonts/enc/ttf2pk/base/T1-WGL4.enc:${PORTSDIR}/print/texlive-ttfutils

OPTIONS_DEFINE=	DOCS SRCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
