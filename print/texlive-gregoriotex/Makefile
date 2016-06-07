# $FreeBSD$

PORTNAME=	gregoriotex
PORTVERSION=	20160510
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	engraving Gregorian Chant scores

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

OPTIONS_DEFINE=	DOCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
