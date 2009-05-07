# New ports collection makefile for:	texlive-luatex
# Date created:		26/01/2009 16:02:51
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	luatex
PORTREVISION=	2
CATEGORIES=	print

MAINTAINER=	romain@blogreen.org
COMMENT=	LuaTeX basic definition package.

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

LSE_LZMA=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
