# $FreeBSD$

PORTNAME=	kotex-utf
PORTVERSION=	20150422
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Typeset Hangul, coded in UTF-8.

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/tex/latex/cjk-ko/cjkutf8-josa.sty:${PORTSDIR}/print/texlive-cjk-ko

OPTIONS_DEFINE=	DOCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
