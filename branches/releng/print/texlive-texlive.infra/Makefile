# New ports collection makefile for:	texlive-texlive.infra
# Date created:		26/01/2009 16:02:49
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	texlive.infra
CATEGORIES=	print
DISTFILES=	# None

MAINTAINER=	romain@blogreen.org
COMMENT=	basic TeX Live infrastructure

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

LSE_LZMA=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
