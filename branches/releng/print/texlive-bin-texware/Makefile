# New ports collection makefile for:	texlive-bin-texware
# Date created:		26/01/2009 16:03:44
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	bin-texware
CATEGORIES=	print
DISTFILES=	# None

MAINTAINER=	romain@blogreen.org
COMMENT=	Utility programs for use with TeX.

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

LSE_LZMA=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
