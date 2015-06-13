# $FreeBSD$

PORTNAME=	wasy2-ps
PORTVERSION=	20150413
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Type 1 versions of wasy2 fonts.

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/fonts/source/public/wasy/lasychr.mf:${PORTSDIR}/print/texlive-wasy

OPTIONS_DEFINE=	DOCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
