# New ports collection makefile for:	texlive-ctex
# Date created:		13/03/2010 04:34:06
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	ctex
PORTVERSION=	20100922
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	LaTeX classes and packages for Chinese typesetting.

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/fonts/sfd/ttf2pk/Big5.sfd:${PORTSDIR}/print/texlive-ttfutils

NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
