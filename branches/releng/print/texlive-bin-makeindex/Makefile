# New ports collection makefile for:	texlive-bin-makeindex
# Date created:		26/01/2009 16:02:48
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	bin-makeindex
PORTREVISION=	2
CATEGORIES=	print
DISTFILES=	# None

MAINTAINER=	romain@blogreen.org
COMMENT=	Process index output to produce typesettable code.

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

LSE_LZMA=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
