# New ports collection makefile for:	texlive-bin-cweb
# Date created:		26/01/2009 16:03:40
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	bin-cweb
PORTREVISION=	11
CATEGORIES=	print
DISTFILES=	# None

MAINTAINER=	romain@blogreen.org
COMMENT=	A Web system in C.

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

LSE_LZMA=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
