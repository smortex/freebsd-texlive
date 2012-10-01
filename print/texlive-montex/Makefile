# New ports collection makefile for:	texlive-montex
# Date created:		13/03/2010 04:37:25
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	montex
PORTVERSION=	20100610
PORTEPOCH=	1
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Mongolian LaTeX.

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/fonts/enc/dvips/cbfonts/CB.enc:${PORTSDIR}/print/texlive-cbfonts

NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
