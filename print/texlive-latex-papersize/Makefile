# $FreeBSD$

PORTNAME=	latex-papersize
PORTVERSION=	20161018
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Calculate LaTeX settings for any font and paper size

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

OPTIONS_DEFINE=	DOCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
