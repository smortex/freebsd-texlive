# $FreeBSD$

PORTNAME=	eplain
PORTVERSION=	20160515
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Extended plain TeX macros

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/fonts/map/dvips/dummy-space/dummy-space.map:${PORTSDIR}/print/texlive-pdftex \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

OPTIONS_DEFINE=	DOCS SRCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
