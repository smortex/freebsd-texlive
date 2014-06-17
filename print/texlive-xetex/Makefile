# $FreeBSD$

PORTNAME=	xetex
PORTVERSION=	20140418
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Unicode and OpenType-enabled TeX engine.

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/tex/generic/xetexconfig/unicode-letters.tex:${PORTSDIR}/print/texlive-xetexconfig \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
