# New ports collection makefile for:	texlive-xindy
# Date created:		26/01/2009 16:03:48
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	xindy
PORTREVISION=	11
CATEGORIES=	print

MAINTAINER=	romain@blogreen.org
COMMENT=	A general-purpose index processor.

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

LSE_LZMA=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
