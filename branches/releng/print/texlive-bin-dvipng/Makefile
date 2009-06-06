# New ports collection makefile for:	texlive-bin-dvipng
# Date created:		26/01/2009 16:05:20
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	bin-dvipng
PORTREVISION=	2
CATEGORIES=	print
DISTFILES=	# None

MAINTAINER=	romain@blogreen.org
COMMENT=	A fast DVI to PNG/GIF converter.

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

LSE_LZMA=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
