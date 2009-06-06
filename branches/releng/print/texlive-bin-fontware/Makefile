# New ports collection makefile for:	texlive-bin-fontware
# Date created:		26/01/2009 16:03:56
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	bin-fontware
PORTREVISION=	2
CATEGORIES=	print
DISTFILES=	# None

MAINTAINER=	romain@blogreen.org
COMMENT=	The bin-fontware package

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

LSE_LZMA=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
