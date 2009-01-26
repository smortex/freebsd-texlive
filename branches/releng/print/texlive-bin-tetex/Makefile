# New ports collection makefile for:	texlive-bin-tetex
# Date created:		26/01/2009 16:02:49
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	bin-tetex
CATEGORIES=	print

MAINTAINER=	romain@blogreen.org
COMMENT=	scripts and files originally written for or included in teTeX

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

LSE_LZMA=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
