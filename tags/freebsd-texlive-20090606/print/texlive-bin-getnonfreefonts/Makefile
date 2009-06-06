# New ports collection makefile for:	texlive-bin-getnonfreefonts
# Date created:		26/01/2009 16:02:48
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	bin-getnonfreefonts
PORTREVISION=	3
CATEGORIES=	print

MAINTAINER=	romain@blogreen.org
COMMENT=	The bin-getnonfreefonts package

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

LSE_LZMA=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
