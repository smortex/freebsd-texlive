# New ports collection makefile for:	texlive-bin-omega
# Date created:		26/01/2009 16:03:58
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	bin-omega
PORTREVISION=	11
CATEGORIES=	print

MAINTAINER=	romain@blogreen.org
COMMENT=	A wide-character-set extension of TeX.

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

LSE_LZMA=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
