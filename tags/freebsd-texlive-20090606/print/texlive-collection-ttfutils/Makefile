# New ports collection makefile for:	texlive-collection-ttfutils
# Date created:		26/01/2009 16:11:59
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	collection-ttfutils
PORTREVISION=	2
CATEGORIES=	print
DISTFILES=	# None

MAINTAINER=	romain@blogreen.org
COMMENT=	TrueType font manipulation

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/fonts/sfd/ttf2pk/Big5.sfd:${PORTSDIR}/print/texlive-bin-ttfutils

LSE_LZMA=	yes
NOPORTDOCS=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
