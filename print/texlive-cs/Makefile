# $FreeBSD$

PORTNAME=	cs
PORTVERSION=	20160428
PORTEPOCH=	1
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Czech/Slovak-tuned Computer Modern fonts

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/fonts/map/dvips/cmexb/cmexb.map:${PORTSDIR}/print/texlive-cmexb

OPTIONS_EXCLUDE=	DOCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
