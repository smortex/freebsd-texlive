# $FreeBSD$

PORTNAME=	latex2nemeth
PORTVERSION=	20161019
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Convert LaTeX source to Braille with math in Nemeth

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

OPTIONS_DEFINE=	DOCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
