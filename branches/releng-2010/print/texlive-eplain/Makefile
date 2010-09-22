# New ports collection makefile for:	texlive-eplain
# Date created:		13/03/2010 04:30:48
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	eplain
PORTVERSION=	20100922
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Extended plain tex macros.

RUN_DEPENDS=	${LOCALBASE}/share/texmf/fonts/map/pdftex/updmap/pdftex.map:${PORTSDIR}/print/texlive-pdftex \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core


.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
