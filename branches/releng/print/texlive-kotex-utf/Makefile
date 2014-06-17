# $FreeBSD$

PORTNAME=	kotex-utf
PORTVERSION=	20140524
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Typeset Hangul, coded in UTF-8.

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/tex/latex/cjk-ko/cjkutf8-josa.sty:${PORTSDIR}/print/texlive-cjk-ko

NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
