# New ports collection makefile for:	texlive-bin-dviljk
# Date created:		26/01/2009 16:03:42
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	bin-dviljk
PORTREVISION=	1
CATEGORIES=	print
DISTFILES=	# None

MAINTAINER=	romain@blogreen.org
COMMENT=	DVI to Laserjet output.

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

LSE_LZMA=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
