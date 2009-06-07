# New ports collection makefile for:	texlive-bin-dvipsk
# Date created:		26/01/2009 16:02:47
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	bin-dvipsk
PORTREVISION=	1
CATEGORIES=	print

MAINTAINER=	romain@blogreen.org
COMMENT=	Convert DVI to PostScript.

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

LSE_LZMA=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
