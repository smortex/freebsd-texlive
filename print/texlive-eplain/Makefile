# $FreeBSD$

PORTNAME=	eplain
PORTVERSION=	20131004
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Extended plain tex macros.

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/fonts/map/pdftex/updmap/pdftex.map:${PORTSDIR}/print/texlive-pdftex \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core


.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
