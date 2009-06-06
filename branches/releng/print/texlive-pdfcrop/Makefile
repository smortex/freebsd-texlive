# New ports collection makefile for:	texlive-pdfcrop
# Date created:		26/01/2009 16:03:47
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	pdfcrop
PORTREVISION=	1
CATEGORIES=	print

MAINTAINER=	romain@blogreen.org
COMMENT=	Crop PDF graphics.

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

LSE_LZMA=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
