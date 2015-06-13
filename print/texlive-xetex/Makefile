# $FreeBSD$

PORTNAME=	xetex
PORTVERSION=	20150427
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Unicode and OpenType-enabled TeX engine.

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/tex/generic/xetexconfig/unicode-letters.tex:${PORTSDIR}/print/texlive-xetexconfig \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

OPTIONS_DEFINE=	DOCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
