# New ports collection makefile for:	texlive-pax
# Date created:		26/01/2009 16:08:48
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	pax
PORTREVISION=	1
CATEGORIES=	print

MAINTAINER=	romain@blogreen.org
COMMENT=	Extract and reinsert PDF annotations with pdfTeX.

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

LSE_LZMA=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
