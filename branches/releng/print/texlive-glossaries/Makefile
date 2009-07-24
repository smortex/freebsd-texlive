# New ports collection makefile for:	texlive-glossaries
# Date created:		26/01/2009 16:08:02
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	glossaries
PORTREVISION=	1
CATEGORIES=	print

MAINTAINER=	romain@blogreen.org
COMMENT=	Create glossaries and lists of acronyms.

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

LSE_LZMA=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
