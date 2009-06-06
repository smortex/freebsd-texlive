# New ports collection makefile for:	texlive-aleph
# Date created:		26/01/2009 16:03:58
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	aleph
PORTREVISION=	2
CATEGORIES=	print
DISTFILES=	# None

MAINTAINER=	romain@blogreen.org
COMMENT=	Extended TeX.

RUN_DEPENDS=	${LOCALBASE}/share/texmf/fmtutil/format.aleph.cnf:${PORTSDIR}/print/texlive-bin-aleph

LSE_LZMA=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
