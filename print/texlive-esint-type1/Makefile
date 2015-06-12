# $FreeBSD$

PORTNAME=	esint-type1
PORTVERSION=	20150412
PORTEPOCH=	1
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Font esint10 in Type 1 format

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/tex/latex/esint/esint.sty:${PORTSDIR}/print/texlive-esint

OPTIONS_DEFINE=	DOCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
