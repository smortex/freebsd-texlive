# New ports collection makefile for:	texlive-a2ping
# Date created:		26/01/2009 16:03:39
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	a2ping
PORTREVISION=	2
CATEGORIES=	print

MAINTAINER=	romain@blogreen.org
COMMENT=	Advanced PS, PDF, EPS converter.

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

LSE_LZMA=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
