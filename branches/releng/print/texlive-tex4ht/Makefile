# New ports collection makefile for:	texlive-tex4ht
# Date created:		26/01/2009 16:05:22
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	tex4ht
PORTREVISION=	11
CATEGORIES=	print

MAINTAINER=	romain@blogreen.org
COMMENT=	Convert (La)TeX to HTML/XML.

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

LSE_LZMA=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
